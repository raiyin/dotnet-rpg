using dotnet_rpg.Dtos.Fight;

namespace dotnet_rpg.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResulltDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResulltDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();
    }
}
