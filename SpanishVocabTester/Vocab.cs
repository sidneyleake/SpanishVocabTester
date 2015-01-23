namespace SpanishVocabTester
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Vocab
    {
        public static Dictionary<string, string> Words;

        static Vocab()
        {
            LoadWords();
        }

        private static void LoadWords()
        {
            Words = new Dictionary<string, string>();
            Words.Add("gracias", "thank you, thanks");
            Words.Add("ser", "to be");
            Words.Add("a", "to");
            Words.Add("ir", "to go");
            Words.Add("estar", "to be");
            Words.Add("bueno", "good");
            Words.Add("de", "of, from");
            Words.Add("su", "your, her, his, their");
            Words.Add("hacer", "to do, to make");
            Words.Add("amigo", "friend");
            Words.Add("por favor", "please");
            Words.Add("no", "no");
            Words.Add("en", "on, in");
            Words.Add("haber", "to have");
            Words.Add("tener", "to have, to possess");
            Words.Add("un, uno, una", "a, an, one");
            Words.Add("ahora", "now");
            Words.Add("y", "and");
            Words.Add("que, qué", "that, what");
            Words.Add("por", "for, by");
            Words.Add("amar", "to love");
            Words.Add("quién", "who");
            Words.Add("para", "for, to");
            Words.Add("venir", "to come");
            Words.Add("porque", "because");
            Words.Add("el, la, los, las", "the");
            Words.Add("antes", "before");
            Words.Add("más", "more");
            Words.Add("bien", "well");
            Words.Add("aquí, allí", "here, there");
            Words.Add("querer", "to want, to love");
            Words.Add("hola", "hello");
            Words.Add("tú", "you");
            Words.Add("poder", "to be able");
            Words.Add("gustar", "to like, to be pleasing");
            Words.Add("poner", "to put");
            Words.Add("casi", "almost");
            Words.Add("saber", "to know");
            Words.Add("como", "like, as");
            Words.Add("donde", "where");
            Words.Add("dar", "to give");
            Words.Add("pero", "but");
            Words.Add("se", "itself, herself, himself, themselves");
            Words.Add("mucho", "much");
            Words.Add("nuevo", "new");
            Words.Add("cuando", "when");
            Words.Add("chico, chica", "boy, girl");
            Words.Add("entender", "to understand");
            Words.Add("si", "if");
            Words.Add("o", "or");
            Words.Add("feliz", "happy");
            Words.Add("todo", "all, every");
            Words.Add("mismo", "same");
            Words.Add("muy", "very");
            Words.Add("nunca", "never");
            Words.Add("yo, me", "I, me");
            Words.Add("sí", "yes");
            Words.Add("grande", "big, great");
            Words.Add("deber", "to owe, should");
            Words.Add("usted", "you");
            Words.Add("bajo", "low, under");
            Words.Add("otro", "other");
            Words.Add("salir", "to leave");
            Words.Add("hora", "hour");
            Words.Add("desde", "from");
            Words.Add("ver", "to see");
            Words.Add("malo, mal", "bad");
            Words.Add("pensar", "to think");
            Words.Add("hasta", "until");
            Words.Add("tanto, tan", "so much, so many");
            Words.Add("entre", "between, among");
            Words.Add("durante", "during");
            Words.Add("llevar", "to wear, to carry");
            Words.Add("siempre", "always");
            Words.Add("empezar", "to begin");
            Words.Add("él, ella, ellos, ellas", "he, she, they");
            Words.Add("leer", "to read");
            Words.Add("cosa", "thing");
            Words.Add("sacar", "to take out, to remove");
            Words.Add("conocer", "to know");
            Words.Add("primero", "first");
            Words.Add("andar", "to walk");
            Words.Add("sobre", "over, about");
            Words.Add("echar", "to throw");
            Words.Add("sin", "without");
            Words.Add("decir", "to say");
            Words.Add("trabajar", "to work");
            Words.Add("nosotros", "we, us");
            Words.Add("también", "also");
            Words.Add("adiós", "goodbye");
            Words.Add("comer", "to eat");
            Words.Add("triste", "sad");
            Words.Add("país", "country");
            Words.Add("escuchar", "to listen, to listen to");
            Words.Add("hombre", "man");
            Words.Add("mujer", "woman");
            Words.Add("le", "you, him, her - indirect-object pronoun");
            Words.Add("creer", "to believe, to think");
            Words.Add("encontrar", "to find");
            Words.Add("beber", "to drink");
        }
    }
}
