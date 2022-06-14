using Text;

Text.TextReader Reader = new Text.TextReader("File1.txt");

Reader.TextReadFromFile();
Reader.TextOutput();
// Ім'я файлу треба було передати як параметр
Reader.PrintSentencesToFile();
Reader.SizeWords();
