using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Boilerplate
{
	class LetterComponent
	{
		public string Text { get; set; }
	}

	class LetterText : LetterComponent
	{ }

	class Letter
	{
		private enum StringType
		{
			Text,
			Field
		}

		/// <summary>
		/// Chunks of text between the fields
		/// </summary>
		private List<LetterComponent> components;
		public List<LetterField> Fields { get; private set; }

		public Letter(string filename)
		{
			components = new List<LetterComponent>();
			Fields = new List<LetterField>();
			StringType currentType = StringType.Text;
			string contents = File.ReadAllText(filename);
			StringBuilder builder = new StringBuilder();
			
			int contlen = contents.Length;
			int line = 1;
			for (int c = 0; c < contlen; ++c)
			{
				char curr = contents[c];

				if (curr == '\n')
					++line;

				switch (curr)
				{
					case '\\':
						if (c != contlen - 1)
						{
							char next = contents[++c];
							switch (next)
							{
								case '<':
									builder.Append('<');
									break;

								case '>':
									builder.Append('>');
									break;

								case '\\':
									builder.Append('\\');
									break;

								default:
									throw new FormatException("Line "
										+ line.ToString()
										+ ": Unrecognized escape sequence \\"
										+ next.ToString());
							}
						}
						else
						{
							throw new FormatException("Line " + line.ToString()
								+ ": The file ended with"
								+ " an escape character (\\)");
						}
						break;

					case '<':
						if (currentType == StringType.Field)
						{
							throw new FormatException("Line " + line.ToString()
								+ ": You cannot have a field in a field");
						}
						else
						{
							// Add the current text to the letter
							if(builder.Length > 0)
							{
								LetterText text = new LetterText();
								text.Text = builder.ToString();
								components.Add(text);
								builder.Length = 0;
							}
							currentType = StringType.Field;
						}
						break;

					case '>':
						if (currentType == StringType.Text)
						{
							throw new FormatException("Line " + line.ToString()
								+ ": > found without matching <");
						}
						else
						{
							// Add the current field to the letter
							if (builder.Length > 0)
							{
								LetterField field = new LetterField();
								field.Name = builder.ToString();
								if(field.Name.Contains("\n"))
								{
									throw new FormatException("Line "
										+ line.ToString()
										+ ": A field cannot span"
										+ " multiple lines");
								}
								components.Add(field);
								Fields.Add(field);
								builder.Length = 0;
								currentType = StringType.Text;
							}
							else
							{
								throw new FormatException("Line "
									+ line.ToString()
									+ ": A field cannot be empty.");
							}
						}
						break;

					default:
						builder.Append(curr);
						break;
				}
			}

			// Deal with the last text component
			if (builder.Length > 0)
			{
				if (currentType == StringType.Field)
				{
					throw new FormatException("The end of the file was reached"
						+ " without finding the end of the last field");
				}
				else
				{
					LetterText text = new LetterText();
					text.Text = builder.ToString();
					components.Add(text);
				}
			}
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			foreach (LetterComponent component in components)
				builder.Append(component.Text);

			return builder.ToString();
		}
	}
}
