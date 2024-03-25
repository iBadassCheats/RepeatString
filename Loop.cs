         while (true)
         {
              for (int npc = 0; npc < 17; npc++)
              {
                   string offsetString = "Addresee + Pointers" + RepeatString(" Repeater Pointer ", npc + 1);

                   if (___.__.ReadInt(offsetString + "384") < 1) // health
                        continue;

                   Console.WriteLine(offsetString);
             }
        }

        static string RepeatString(string str, int count)
        {
            string repeated = "";
            for (int i = 0; i < count; i++)
            {
                repeated += str;
            }
            return repeated;
        }
