//======================================
//      キャラクター
//======================================
using System;
using Utility = GP2.Utility;

namespace TurnBattle_CS
{
    class Character
    {
        const int SPELL_COST = 3;
        private int m_hp;
        private int m_maxHp;
        private int m_mp;
        private int m_maxMp;
        private int m_attack;
        private string m_name;
        private string m_aa;
        private bool m_isEscape;
        private bool m_isEraseAa;

        public const string EscBLACK = "\x1b[30m";
        public const string EscRED = "\x1b[31m";
        public const string EscGREEN = "\x1b[32m";
        public const string EscYELLOW = "\x1b[33m";
        public const string EscBLUE = "\x1b[34m";
        public const string EscMAZENTA = "\x1b[35m";
        public const string EscCYAN = "\x1b[36m";
        public const string EscWHITE = "\x1b[37m";
        public const string EscDEFAULT = "\x1b[39m";

        public const string EscBgBLACK = "\x1b[40m";
        public const string EscBgRED = "\x1b[41m";
        public const string EscBgGREEN = "\x1b[42m";
        public const string EscBgYELLOW = "\x1b[43m";
        public const string EscBgBLUE = "\x1b[44m";
        public const string EscBgMAZENTA = "\x1b[45m";
        public const string EscBgCYAN = "\x1b[46m";
        public const string EscBgWHITE = "\x1b[47m";
        public const string EscBgDEFAULT = "\x1b[49m";

        // コンストラクタ
        public Character(int hp, int mp, int attack, string name, string aa)
        {
            m_maxHp = hp;
            m_maxMp = mp;
            m_attack = attack;
            m_name = name;
            m_aa = aa;
        }
        // 戦闘開始
        public void Start()
        {
            m_hp = m_maxHp;
            m_mp = m_maxMp;
            m_isEscape = false;
            m_isEraseAa = false;
        }
        // 死亡か?
        public bool IsDead()
        {
            return m_hp == 0;
        }
        // ダメージ受ける
        public void Damage(int dmg)
        {
            m_hp -= dmg;
            if (m_hp < 0)
            {
                m_hp = 0;
            }
        }
        // 回復する
        public void Recover()
        {
            m_hp = m_maxHp;
        }
        // 呪文できるか?
        public bool CanSpell()
        {
            return m_mp >= SPELL_COST;
        }
        // 呪文を使う
        public void UseSpell()
        {
            m_mp -= SPELL_COST;
            if (m_mp < 0)
            {
                m_mp = 0;
            }
        }
        // プレーヤ表示
        public void IndicatePlayer()
        {
            if (m_hp <= m_maxHp / 5)
            {
                Utility.Printf(EscRED);
                Utility.Printf("{0}\n", m_name);
                Utility.Printf("ＨＰ：{0,3}／{1}　ＭＰ：{2,2}／{3}\n", m_hp, m_maxHp, m_mp, m_maxMp);
                Utility.Printf(EscDEFAULT);
            }
            else if (m_hp <= m_maxHp / 3)
            {
                Utility.Printf(EscYELLOW);
                Utility.Printf("{0}\n", m_name);
                Utility.Printf("ＨＰ：{0,3}／{1}　ＭＰ：{2,2}／{3}\n", m_hp, m_maxHp, m_mp, m_maxMp);
                Utility.Printf(EscDEFAULT);
            }
            else
            {
                Utility.Printf("{0}\n", m_name);
                Utility.Printf("ＨＰ：{0,3}／{1}　ＭＰ：{2,2}／{3}\n", m_hp, m_maxHp, m_mp, m_maxMp);
            }

        }
        // 敵表示
        public void IndicateEnemy()
        {
            if (m_isEraseAa == false)
            {
                Utility.Printf("{0}", m_aa);
            }
            if (m_hp <= m_maxHp / 5)
            {
                Utility.Printf(EscRED);
                Utility.Printf("（ＨＰ：{0,3}／{1}）\n", m_hp, m_maxHp);
                Utility.Printf(EscDEFAULT);
            }
            else if (m_hp <= m_maxHp / 3)
            {
                Utility.Printf(EscYELLOW);
                Utility.Printf("（ＨＰ：{0,3}／{1}）\n", m_hp, m_maxHp);
                Utility.Printf(EscDEFAULT);
            }
            else
            {
                Utility.Printf("（ＨＰ：{0,3}／{1}）\n", m_hp, m_maxHp);
            }

        }
        public int CalcDamage()
        {
            int dmg = Utility.GetRand(m_attack) + 1;
            return dmg;
        }
        // 名前を取得
        public String Name
        {
            get { return m_name; }
        }
        // にげたか?
        public bool IsEscape
        {
            get { return m_isEscape; }
            set { m_isEscape = value; }
        }
        // アスキーアート消去設定
        public bool IsEraseAa
        {
            get { return m_isEraseAa; }
            set { m_isEraseAa = value; }
        }
    } // class Character
} // namespace