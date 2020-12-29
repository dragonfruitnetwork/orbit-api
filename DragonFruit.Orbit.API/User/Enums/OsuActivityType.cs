// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.User.Enums
{
    public enum OsuActivityType
    {
        [Description("Achievement unlocked")]
        [ExternalValue("achievement")]
        AchievementUnlocked,

        [Description("Beatmap playcount milestone")]
        [ExternalValue("beatmapPlaycount")]
        BeatmapPlayCount,

        [Description("Beatmapset Approved, Loved, Ranked or Qualified")]
        [ExternalValue("beatmapsetApprove")]
        BeatmapsetApproved,

        [Description("Beatmapset deleted")]
        [ExternalValue("beatmapsetDelete")]
        BeatmapsetDeleted,

        [Description("Beatmapset revived from Graveyard")]
        [ExternalValue("beatmapsetRevive")]
        BeatmapsetRevived,

        [Description("Beatmapset uploaded")]
        [ExternalValue("beatmapsetUpload")]
        BeatmapsetUpload,

        [Description("Beatmapset update submitted")]
        [ExternalValue("beatmapsetUpdate")]
        BeatmapsetUpdate,

        [Description("Rank achieved on beatmap")]
        [ExternalValue("rank")]
        RankAchieved,

        [Description("First place lost on beatmap")]
        [ExternalValue("rankLost")]
        RankLost,

        [Description("User supported osu! again")]
        [ExternalValue("userSupportAgain")]
        UserSupportAgain,

        [Description("User supported osu! for the first time")]
        [ExternalValue("userSupportFirst")]
        UserSupportFirst,

        [Description("User recieved osu! supporter as a gift")]
        [ExternalValue("userSupportGift")]
        UserSupportGift,

        [Description("Username changed")]
        [ExternalValue("usernameChange")]
        UsernameChange
    }
}
