Requirements:

Microsoft .NET Framework 2.0 or greater (for Windows),
or Mono (for OSX and Linux)

Usage:

Boilerplate takes a text file tagged with fields to be filled in.
It's useful for tasks such as quickly filling out form letters and emails to
multiple recipients.

When it opens a file, Boilerplate scans for tags surrounded in < > characters.
Consequently, to have either show up normally in the resulting document,
use \< and \>, respectively. Since \ is used as an escape character, use
\\ where you want the character \ to show up in your final document. Boilerplate
extracts the tags and provides text boxes for each flag it found. Once
these text boxes are filled in, the user can click the "Document to Clipboard"
button, upon which the document (with all tags filled in with the text provided
in the text boxes) will be copied to the clipboard for easy pasting.

An example document might look like the following.

Dear <Name>,

Did you know that Boilerplate is awesome? It makes it easy to quickly fill out
batches of documents, such as login request emails or <Other Document Type>!

Even though it uses the \< and \> characters to mark tags, you can still put
them in your documents easily using the \\ key!

From,
<My Name>

License:

Copyright (c) 2011 Matt Kline

This software is provided 'as-is', without any express or implied
warranty. In no event will the authors be held liable for any damages
arising from the use of this software.

Permission is granted to anyone to use this software for any purpose,
including commercial applications, and to alter it and redistribute it
freely, subject to the following restrictions:

   1. The origin of this software must not be misrepresented; you must not
   claim that you wrote the original software. If you use this software
   in a product, an acknowledgment in the product documentation would be
   appreciated but is not required.

   2. Altered source versions must be plainly marked as such, and must not be
   misrepresented as being the original software.

   3. This notice may not be removed or altered from any source
   distribution.
