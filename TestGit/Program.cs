// git
// stage = 변경사항 올리기
// commit = 변경사항을 버전에 기록하기
// diff = 변경과 현재사항 확인
// stash = 기록되지 않은 내용을 임시저장소에 잠시 보관
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
    public class Skill
    {
        // stash 후 작업
    }

    public class Item
    {
        // 작업도중 stash
    }
}