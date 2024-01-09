// git
// config = git의 사용환경 설정 (전역설정/리포지토리 설정 등)
//          *리포지토리 설정이 전역설정보다 먼저 적용됨.
// init = 버전 관리를 시작하기 위한 git 저장소를 생성
// stage = 변경사항 올리기
// commit = 변경사항을 버전에 기록하기
// diff = 변경과 현재사항 확인
// stash = 기록되지 않은 내용을 임시저장소에 잠시 보관
// restore = 변경내용 취소 (원복)
// revert = 변경 내용을 반대로 (되돌리기) 
// reset = 선택한 항목의 상위항목(선택한 항목보다 최근의 항목)을 삭제 (hard:기록과 파일 모두 삭제, mixed:기록은 삭제 / 파일은 유지)


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