using System;

namespace LineProject
{
    public class Child
    {
        public static void Main()
        {

            int choice = 3;
            /*
            Use 1, 2, or 3
            I was going to add more but I don't know wjat I wanted to say
            and commented multiple lines so this text is here to take up space
            */


            //Btw both take the same time to build
            // Pretty cool


            #region Choice 1 and 2

            if (choice == 1)
            {
                // Normal code
                // 9 lines
                // 7 discounting spaces
                Console.WriteLine("Please enter your password\n");

                Console.WriteLine("You have the ability to save the children in my basement");
                Console.WriteLine("Be a good person\n");

                Console.WriteLine("Password: ");
                string password1 = Console.ReadLine();

                Console.WriteLine($"\nThanks for the password, it is {password1}");
                Console.WriteLine("Your local ip is probably 192.168.1.1");
            }
            else if (choice == 2)
            {
                // This is how alphas write code
                // 3 lines
                Console.WriteLine("Please enter your password: \n\nYou have the ability to save the children in my basement\nBe a good person\n\nPassword: ");
                string password2 = Console.ReadLine();
                Console.WriteLine($"\nThanks for the password, it is {password2}\nYour local ip is probably 192.168.1.1");

            }
            #endregion

            else if (choice == 3)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 100);

                do
                {
                    // Adds 0.022 seconds
                    randomNumber = random.Next(1, 100);
                } while (randomNumber != 67);

                int integer = 0;

                #region All letters are equal to a number in order

                int a = 1;
                int b = 2;
                int c = 3;
                int d = 4;
                int e = 5;
                int f = 6;
                int g = 7;
                int h = 8;
                int i = 9;
                int j = 10;
                int k = 11;
                int l = 12;
                int m = 13;
                int n = 14;
                int o = 15;
                int p = 16;
                int q = 17;
                int r = 18;
                int s = 19;
                int t = 20;
                int u = 21;
                int v = 22;
                int w = 23;
                int x = 24;
                int y = 25;
                int z = 26;
                #endregion

                #region All letters as chars

                string letter_a_value = a.ToString();
                string letter_b_value = b.ToString();
                string letter_c_value = c.ToString();
                string letter_d_value = d.ToString();
                string letter_e_value = e.ToString();
                string letter_f_value = f.ToString();
                string letter_g_value = g.ToString();
                string letter_h_value = h.ToString();
                string letter_i_value = i.ToString();
                string letter_j_value = j.ToString();
                string letter_k_value = k.ToString();
                string letter_l_value = l.ToString();
                string letter_m_value = m.ToString();
                string letter_n_value = n.ToString();
                string letter_o_value = o.ToString();
                string letter_p_value = p.ToString();
                string letter_q_value = q.ToString();
                string letter_r_value = r.ToString();
                string letter_s_value = s.ToString();
                string letter_t_value = t.ToString();
                string letter_u_value = u.ToString();
                string letter_v_value = v.ToString();
                string letter_w_value = w.ToString();
                string letter_x_value = x.ToString();
                string letter_y_value = y.ToString();
                string letter_z_value = z.ToString();
                #endregion

                #region All letters as chars lowercase

                string letter_a = "a";
                string letter_b = "b";
                string letter_c = "c";
                string letter_d = "d";
                string letter_e = "e";
                string letter_f = "f";
                string letter_g = "g";
                string letter_h = "h";
                string letter_i = "i";
                string letter_j = "j";
                string letter_k = "k";
                string letter_l = "l";
                string letter_m = "m";
                string letter_n = "n";
                string letter_o = "o";
                string letter_p = "p";
                string letter_q = "q";
                string letter_r = "r";
                string letter_s = "s";
                string letter_t = "t";
                string letter_u = "u";
                string letter_v = "v";
                string letter_w = "w";
                string letter_x = "x";
                string letter_y = "y";
                string letter_z = "z";
                #endregion

                #region All letters as chars uppercase

                string letter_a_upper = "A";
                string letter_b_upper = "B";
                string letter_c_upper = "C";
                string letter_d_upper = "D";
                string letter_e_upper = "E";
                string letter_f_upper = "F";
                string letter_g_upper = "G";
                string letter_h_upper = "H";
                string letter_i_upper = "I";
                string letter_j_upper = "J";
                string letter_k_upper = "K";
                string letter_l_upper = "L";
                string letter_m_upper = "M";
                string letter_n_upper = "N";
                string letter_o_upper = "O";
                string letter_p_upper = "P";
                string letter_q_upper = "Q";
                string letter_r_upper = "R";
                string letter_s_upper = "S";
                string letter_t_upper = "T";
                string letter_u_upper = "U";
                string letter_v_upper = "V";
                string letter_w_upper = "W";
                string letter_x_upper = "X";
                string letter_y_upper = "Y";
                string letter_z_upper = "Z";
                #endregion

                string symbol_colon = ":";
                string symbol_space = " ";
                string next_line = "\n";


                bool space = false;
                bool nextLine = false;

                // Please enter your password:
                bool Please = false;
                bool enter = false;
                bool your = false;
                bool password = false;
                bool colon = false;

                //You have the ability to save the children in my basement
                bool You = false;
                bool have = false;
                bool the = false;
                bool ability = false;
                bool to = false;
                bool save = false;
                //bool the = false; // already declared
                bool children = false;
                bool in_ = false;
                bool my = false;
                bool basement = false;



                // Random number with async 
                for (integer = 0; integer <= 7; integer++)
                {
                    #region You have the ability to save the children in my basement
                    if (Please == false)
                    {
                        Console.Write(letter_p_upper);
                        Console.Write(letter_l);
                        Console.Write(letter_e);
                        Console.Write(letter_a);
                        Console.Write(letter_s);
                        Console.Write(letter_e);
                        Please = true;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (enter == false)
                    {
                        Console.Write(letter_e);
                        Console.Write(letter_n);
                        Console.Write(letter_t);
                        Console.Write(letter_e);
                        Console.Write(letter_r);
                        enter = true;
                        space = false;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (your == false)
                    {
                        Console.Write(letter_y);
                        Console.Write(letter_o);
                        Console.Write(letter_u);
                        Console.Write(letter_r);
                        your = true;
                        space = false;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (password == false)
                    {
                        Console.Write(letter_p);
                        Console.Write(letter_a);
                        Console.Write(letter_s);
                        Console.Write(letter_s);
                        Console.Write(letter_w);
                        Console.Write(letter_o);
                        Console.Write(letter_r);
                        Console.Write(letter_d);
                        password = true;
                    }
                    else if (colon == false)
                    {
                        Console.Write(symbol_colon);
                        colon = true;
                    }
                    else
                    {
                        nextLine = false;
                        space = false;
                    }
                    #endregion
                }

                if (nextLine == false)
                {
                    Console.Write(next_line);
                    Console.Write(next_line);
                    nextLine = true;
                }
                for (integer = 0; integer <= 13; integer++)
                {
                    //#region You have the ability to save the children in my basement
                    if (You == false)
                    {
                        Console.Write(letter_y_upper);
                        Console.Write(letter_o);
                        Console.Write(letter_u);
                        You = true;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (have == false)
                    {
                        Console.Write(letter_h);
                        Console.Write(letter_a);
                        Console.Write(letter_v);
                        Console.Write(letter_e);
                        have = true;
                        space = false;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (the == false)
                    {
                        Console.Write(letter_t);
                        Console.Write(letter_h);
                        Console.Write(letter_e);
                        the = true;
                        space = false;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (ability == false)
                    {
                        Console.Write(letter_a);
                        Console.Write(letter_b);
                        Console.Write(letter_i);
                        Console.Write(letter_l);
                        Console.Write(letter_i);
                        Console.Write(letter_t);
                        Console.Write(letter_y);
                        ability = true;
                        space = false;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (to == false)
                    {
                        Console.Write(letter_t);
                        Console.Write(letter_o);
                        to = true;
                        space = false;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (save == false)
                    {
                        Console.Write(letter_s);
                        Console.Write(letter_a);
                        Console.Write(letter_v);
                        Console.Write(letter_e);
                        save = true;
                        space = false;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (the == false)
                    {
                        Console.Write(letter_t);
                        Console.Write(letter_h);
                        Console.Write(letter_e);
                        the = true;
                        space = false;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (You == false)
                    {
                        Console.Write(letter_y_upper);
                        Console.Write(letter_o);
                        Console.Write(letter_u);
                        You = true;
                    }
                    else if (space == false)
                    {
                        Console.Write(symbol_space);
                        space = true;
                    }
                    else if (have == false)
                    {
                        Console.Write(letter_h);
                        Console.Write(letter_a);
                        Console.Write(letter_v);
                        Console.Write(letter_e);
                        have = true;
                        space = true;
                    }
                    else
                    {
                        nextLine = false;
                        space = false;
                    }
                }
            }
        }
    }
}