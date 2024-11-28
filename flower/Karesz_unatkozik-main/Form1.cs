using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        void Karesz_the_adventurer()
        {
            Fordulj(jobbra);
            while(Van_e_előttem_fal())
            {
                if(!Van_e_előttem_fal())
                            {
                                Lépj();
                            }
            }
            
            
            Fordulj(jobbra);
            while (!Van_e_előttem_fal())
            {
                Lépj();
            }
            Fordulj(jobbra);
            Fordulj(jobbra);
        }
        // IDE JÖNNEK AZ ELJÁRÁSOK ÉS FÜGGVÉNYEK
        bool kész = false;
        void Pálya_szélén_fordulj(int irány)
        {
            Fordulj(irány);
            if (Kilépek_e_a_pályáról())// pálya szélén fordulva megint pálya széle van => sarokban van!
            {
                kész = true;
            }
            else
            {
                Lépj();
                Fordulj(irány);

            }

        }
        void flower()
        {
            if(Mi_van_alattam() == sárga)
            {
                Lépj();
                Tegyél_le_egy_kavicsot(zöld);
                Fordulj(jobbra);
                Fordulj(jobbra);
                Lépj();
                Lépj();
                Tegyél_le_egy_kavicsot(zöld);
                Fordulj(jobbra);
                Fordulj(jobbra);
                Lépj();
                Fordulj(jobbra);
                Lépj();
                Tegyél_le_egy_kavicsot(zöld);
                Fordulj(jobbra);
                Fordulj(jobbra);
                Lépj();
                Lépj();
                Tegyél_le_egy_kavicsot(zöld);
                Fordulj(jobbra);
                Fordulj(jobbra);
                Lépj();
                Fordulj(balra);
            }
        }

        void DIÁK_ROBOTJAI()
        {
            Robot.Get("Karesz").Feladat = delegate ()
            {
                // IDE ÍRD AZ UTASÍTÁSOKAT!

                int irány = jobbra;
                Karesz_the_adventurer();
                while (!kész)
                {
                    if (!Kilépek_e_a_pályáról())
                    {
                        Lépj();
                        flower();
                    }
                    else
                    {
                        Pálya_szélén_fordulj(irány);
                        irány = -irány;
                    }

                }



            };
        }

    }
}