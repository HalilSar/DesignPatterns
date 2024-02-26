using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
   public class CharacterManager
    {

        private static CharacterManager manager = new CharacterManager();
        private  List<Character> characters = new List<Character>();
        private Character[,] document = new Character[50,50];

        private CharacterManager()
        {

        }

        public static CharacterManager GetInstance() => manager;

        public static Character GetCharacter(string character)
        {

            Character characterVal = null;
            for (int i = 0; i < manager.characters.Count; i++)
            {
                Character temp = manager.characters[i];
                if(temp.CharacterValue.Equals(character))
                {
                    characterVal = temp;
                    break;
                }
            }

            if (characterVal==null)
            {
                characterVal = new Character(character);
                manager.characters.Add(characterVal);
            }
            return characterVal;
        }

        public void AddLine(string line,int lineNo)
        {
            for (int i = 0; i < line.Length; i++)
            {
                string character = line.Substring(i, i + 1);
                document[lineNo, i] = GetCharacter(character);
            }
        }

        public static void GetDocument()
        {
            for (int i = 0; i < 50; i++)
            {
                for (int j  = 0;  j < 50 ; j++)
                {
                    if (manager.document[i, j] != null)
                    {
                        Console.WriteLine(GetCharacter(manager.document[i, j].ToString()));
                    }

                    else break;
                }

                if (manager.document[i,0]!=null)
                {
                    Console.WriteLine("");
                }

            }

            Console.WriteLine("Character Count : " + manager.characters.Count);
        }

        public List<Character> GetCharacters() => characters;

        public void SetCharacters(List<Character> characters) => this.characters = characters;

        


    }
}
