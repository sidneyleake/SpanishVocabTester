namespace SpanishVocabTester
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Quiz
    {
        public static Dictionary<string, string> Vocab;
        public static Dictionary<string, string> Verbs;

        static Quiz()
        {
            LoadVocab();
            LoadVerbs();
        }

        private static void LoadVocab()
        {
            Vocab = new Dictionary<string, string>();
            Vocab.Add("gracias", "thank you, thanks");
            Vocab.Add("ser", "to be");
            Vocab.Add("a", "to");
            Vocab.Add("ir", "to go");
            Vocab.Add("estar", "to be");
            Vocab.Add("bueno", "good");
            Vocab.Add("de", "of, from");
            Vocab.Add("su", "your, her, his, their");
            Vocab.Add("hacer", "to do, to make");
            Vocab.Add("amigo", "friend");
            Vocab.Add("por favor", "please");
            Vocab.Add("no", "no");
            Vocab.Add("en", "on, in");
            Vocab.Add("haber", "to have");
            Vocab.Add("tener", "to have, to possess");
            Vocab.Add("un, uno, una", "a, an, one");
            Vocab.Add("ahora", "now");
            Vocab.Add("y", "and");
            Vocab.Add("que, qué", "that, what");
            Vocab.Add("por", "for, by");
            Vocab.Add("amar", "to love");
            Vocab.Add("quién", "who");
            Vocab.Add("para", "for, to");
            Vocab.Add("venir", "to come");
            Vocab.Add("porque", "because");
            Vocab.Add("el, la, los, las", "the");
            Vocab.Add("antes", "before");
            Vocab.Add("más", "more");
            Vocab.Add("bien", "well");
            Vocab.Add("aquí, allí", "here, there");
            Vocab.Add("querer", "to want, to love");
            Vocab.Add("hola", "hello");
            Vocab.Add("tú", "you");
            Vocab.Add("poder", "to be able");
            Vocab.Add("gustar", "to like, to be pleasing");
            Vocab.Add("poner", "to put");
            Vocab.Add("casi", "almost");
            Vocab.Add("saber", "to know");
            Vocab.Add("como", "like, as");
            Vocab.Add("donde", "where");
            Vocab.Add("dar", "to give");
            Vocab.Add("pero", "but");
            Vocab.Add("se", "itself, herself, himself, themselves");
            Vocab.Add("mucho", "much");
            Vocab.Add("nuevo", "new");
            Vocab.Add("cuando", "when");
            Vocab.Add("chico, chica", "boy, girl");
            Vocab.Add("entender", "to understand");
            Vocab.Add("si", "if");
            Vocab.Add("o", "or");
            Vocab.Add("feliz", "happy");
            Vocab.Add("todo", "all, every");
            Vocab.Add("mismo", "same");
            Vocab.Add("muy", "very");
            Vocab.Add("nunca", "never");
            Vocab.Add("yo, me", "I, me");
            Vocab.Add("sí", "yes");
            Vocab.Add("grande", "big, great");
            Vocab.Add("deber", "to owe, should");
            Vocab.Add("usted", "you");
            Vocab.Add("bajo", "low, under");
            Vocab.Add("otro", "other");
            Vocab.Add("salir", "to leave");
            Vocab.Add("hora", "hour");
            Vocab.Add("desde", "from");
            Vocab.Add("ver", "to see");
            Vocab.Add("malo, mal", "bad");
            Vocab.Add("pensar", "to think");
            Vocab.Add("hasta", "until");
            Vocab.Add("tanto, tan", "so much, so many");
            Vocab.Add("entre", "between, among");
            Vocab.Add("durante", "during");
            Vocab.Add("llevar", "to wear, to carry");
            Vocab.Add("siempre", "always");
            Vocab.Add("empezar", "to begin");
            Vocab.Add("él, ella, ellos, ellas", "he, she, they");
            Vocab.Add("leer", "to read");
            Vocab.Add("cosa", "thing");
            Vocab.Add("sacar", "to take out, to remove");
            Vocab.Add("conocer", "to know");
            Vocab.Add("primero", "first");
            Vocab.Add("andar", "to walk");
            Vocab.Add("sobre", "over, about");
            Vocab.Add("echar", "to throw");
            Vocab.Add("sin", "without");
            Vocab.Add("decir", "to say");
            Vocab.Add("trabajar", "to work");
            Vocab.Add("nosotros", "we, us");
            Vocab.Add("también", "also");
            Vocab.Add("adiós", "goodbye");
            Vocab.Add("comer", "to eat");
            Vocab.Add("triste", "sad");
            Vocab.Add("país", "country");
            Vocab.Add("escuchar", "to listen, to listen to");
            Vocab.Add("hombre", "man");
            Vocab.Add("mujer", "woman");
            Vocab.Add("le", "you, him, her - indirect-object pronoun");
            Vocab.Add("creer", "to believe, to think");
            Vocab.Add("encontrar", "to find");
            Vocab.Add("beber", "to drink");
        }

        private static void LoadVerbs()
        {
            Verbs = new Dictionary<string, string>();
            var temp = new Dictionary<string, string>();
            temp.Add("to accept", "aceptar");
            temp.Add("to allow", "permitir, dejar");
            temp.Add("to ask", "preguntar");
            temp.Add("to believe", "creer");
            temp.Add("to borrow", "prestar");
            temp.Add("to break", "romper");
            temp.Add("to bring", "traer");
            temp.Add("to buy", "comprar");
            temp.Add("to be able, can", "poder");
            temp.Add("to cancel", "cancelar");
            temp.Add("to change", "cambiar");
            temp.Add("to clean", "limpiar");
            temp.Add("to comb", "peinar");
            temp.Add("to complain", "quejarse");
            temp.Add("to cough", "toser");
            temp.Add("to count", "contar");
            temp.Add("to cut", "cortar");
            temp.Add("to dance", "bailar");
            temp.Add("to draw", "dibujar");
            temp.Add("to drink", "beber");
            temp.Add("to drive", "conducir");
            temp.Add("to eat", "comer");
            temp.Add("to explain", "explicar");
            temp.Add("to fall", "caerse");
            temp.Add("to fill", "llenar");
            temp.Add("to find", "encontrar");
            temp.Add("to finish", "terminar");
            temp.Add("to fit", "caber");
            temp.Add("to fix", "reparar");
            temp.Add("to fly", "volar");
            temp.Add("to forget", "olvidar");
            temp.Add("to give", "dar");
            temp.Add("to go", "ir");
            temp.Add("to have, to possess", "tener");
            temp.Add("to hear", "oir");
            temp.Add("to hurt", "dañar, herir");
            temp.Add("to know", "saber, conocer");
            temp.Add("to learn", "aprender");
            temp.Add("to leave", "salir, marcharse");
            temp.Add("to listen", "escuchar");
            temp.Add("to live", "vivir");
            temp.Add("to look, to watch", "mirar");
            temp.Add("to lose", "perder");
            temp.Add("to make, to do", "hacer");
            temp.Add("to need", "necesitar");
            temp.Add("to open", "abrir");
            temp.Add("to close, to shut", "cerrar");
            temp.Add("to organize", "organizar");
            temp.Add("to pay", "pagar");
            temp.Add("to play", "jugar");
            temp.Add("to put", "poner");
            temp.Add("to rain", "llover");
            temp.Add("to read", "leer");
            temp.Add("to reply", "responder");
            temp.Add("to run", "correr");
            temp.Add("to say, to tell", "decir");
            temp.Add("to see", "ver");
            temp.Add("to sell", "vender");
            temp.Add("to send", "enviar");
            temp.Add("to sign", "firmar");
            temp.Add("to sing", "cantar");
            temp.Add("to sit", "sentarse");
            temp.Add("to sleep", "dormir");
            temp.Add("to smoke", "fumar");
            temp.Add("to speak, to talk", "hablar");
            temp.Add("to spell", "deletrear");
            temp.Add("to spend", "gastar");
            temp.Add("to stand", "ponerse de pie");
            temp.Add("to start, to begin", "comenzar");
            temp.Add("to study", "estudiar");
            temp.Add("to succeed", "tener exito");
            temp.Add("to swim", "nadar");
            temp.Add("to take", "tomar");
            temp.Add("to teach", "enseñar");
            temp.Add("to think", "pensar");
            temp.Add("to translate", "traducir");
            temp.Add("to travel", "viajar");
            temp.Add("to try", "intentar");
            temp.Add("to turn off", "apagar");
            temp.Add("to turn on", "encender");
            temp.Add("to type", "escribir a máquina");
            temp.Add("to understand", "entender");
            temp.Add("to use", "utilizar, usar");
            temp.Add("to wait", "esperar");
            temp.Add("to wake up", "despertar");
            temp.Add("to want", "querer, desear");
            temp.Add("to work", "trabajar");
            temp.Add("to worry", "preocuparse");
            temp.Add("to write", "escribir");
            foreach(var set in temp)
            {
                var x = 0;
                if(Verbs.ContainsKey(set.Value))
                {
                    x = 1;
                }

                Verbs.Add(set.Value, set.Key);
            }
        }
    }
}
