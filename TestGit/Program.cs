// git
// stage = 변경사항 올리기
// commit = 변경사항을 버전에 기록하기
// 
//

namespace TestGit
{
    public class Player
    {
        public int hp;
        public void Attack() { }
    }

    public class Monster
    {
        public int hp;
        public void TakeDamage(Player owner) { }
    }
}