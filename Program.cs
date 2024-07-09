// See https://aka.ms/new-console-template for more information
string[] harryPotterFilms = {
    "Harry Potter and the Philosophers Stone",
    "Harry Potter and the Chamber of Secrets",
    "Harry Potter and the Prisoner of Azkaban",
    "Harry Potter and the Goblet of Fire",
    "Harry Potter and the Order of Phoenix",
    "Harry Potter and the Half Blood Prince",
    "Harry Potter and the Deathly Hallows Part One",
    "Harry Potter and the Deathly Hallows Part Two"
};

Random random = new Random();

int filmChoice = random.Next(harryPotterFilms.Length);

string chosenFilm = harryPotterFilms[filmChoice];
Console.WriteLine($"The chosen film is{chosenFilm}");