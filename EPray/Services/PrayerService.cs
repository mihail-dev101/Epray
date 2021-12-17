﻿using EPray.EntityFramework;
using EPray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPray.Services
{
    public static class PrayerService
    {
        public static void PopulatePrayerDB(PrayerContext context)
        {
            var prayer1 = new PrayerModel();
            prayer1.Id = 1;
            prayer1.Lyrics = "Lord, we are not ready to have a child right now. \n If it be your will, please let us not be pregnant now and instead get pregnant later.\n But if not, then please give us the grace to handle this massive change in our lives in welcoming this little person.";
            prayer1.Reason = PrayerReasonType.PREGNANCY_PREVENTION;
            prayer1.Religion = ReligionType.CHRISTIAN;
            context.Prayers.Add(prayer1);

            var prayer2 = new PrayerModel();
            prayer2.Id = 2;
            prayer2.Lyrics = "I humbly pray that you look after those who are suffering from cancer.\n Please give them the strength and courage needed to overcome their tribulation.\n Lord, help me to be aware of and to never take for granted the health and gifts which you have blessed me with.";
            prayer2.Reason = PrayerReasonType.CANCER;
            prayer2.Religion = ReligionType.CHRISTIAN;
            context.Prayers.Add(prayer2);

            var prayer3 = new PrayerModel();
            prayer3.Id = 3;
            prayer3.Lyrics = "My Father, I thank you for your love and kindness towards me and my family in Jesus Name. \n My Father, I worship you for your protection and provision for me and my household in Jesus Name \n Oh Lord, I decree and declare that diabetes will never find a place to stay in my body system in Jesus Name";
            prayer3.Reason = PrayerReasonType.DIABETIS;
            prayer3.Religion = ReligionType.CHRISTIAN;
            context.Prayers.Add(prayer3);

            var prayer4 = new PrayerModel();
            prayer4.Id = 4;
            prayer4.Lyrics = "Think, O' God, of our friend who is ill, whom we now commend to Your compassionate regard. that no healing is too hard if it be Your will.\n We therefore pray that You bless our friend with Your loving care, renew his/her strength,\n and heal what ails him/her in Your loving name.";
            prayer4.Reason = PrayerReasonType.GENERAL;
            prayer4.Religion = ReligionType.CHRISTIAN;
            context.Prayers.Add(prayer4);

            var prayer5 = new PrayerModel();
            prayer5.Id = 5;
            prayer5.Lyrics = "Father, let the blood of Jesus. the fire and the living water of the God wash my system clean from satanic poison food, in Jesus name.";
            prayer5.Reason = PrayerReasonType.COLESTEROL;
            prayer5.Religion = ReligionType.CHRISTIAN;
            context.Prayers.Add(prayer5);

            var prayer6 = new PrayerModel();
            prayer6.Id = 6;
            prayer6.Lyrics = "Lord, I thank You for this baby and I give my pregnancy to You, praying that throughout the whole time You will be there to comfort and encourage and strengthen each member of the family. I pray that You would place Your hand of blessing on this little human being that is being formed in my womb...";
            prayer6.Reason = PrayerReasonType.PREGNANCY;
            prayer6.Religion = ReligionType.CHRISTIAN;
            context.Prayers.Add(prayer6);

            var prayer7 = new PrayerModel();
            prayer7.Id = 7;
            prayer7.Lyrics = "Father I pray blessings on this request and for the healing of this condition in Jesus name I pray.";
            prayer7.Reason = PrayerReasonType.HEMOROIDS;
            prayer7.Religion = ReligionType.CHRISTIAN;
            context.Prayers.Add(prayer7);

            var prayer8 = new PrayerModel();
            prayer8.Id = 8;
            prayer8.Lyrics = "Lord Jesus Christ, I confess here and now that you are my Creator (John 1:3) and therefore the creator of my sexuality. I confess that you are also my Savior, that you have ransomed me with your blood (1 Corinthians 15:3, Matthew 20:28). I have been bought with the blood of Jesus Christ; my life and my body belong to God (1 Corinthians 6:19–20). Jesus, I present myself to you now to be made whole and holy in every way, including in my sexuality. You ask us to present our bodies to you as living sacrifices (Romans 12:1) and the parts of our bodies as instruments of righteousness (Romans 6:13). I do this now. I present my body, my sexuality and I present my sexual nature to you. I consecrate my sexuality to Jesus Christ.";
            prayer8.Reason = PrayerReasonType.POTENCY;
            prayer8.Religion = ReligionType.CHRISTIAN;
            context.Prayers.Add(prayer8);

            //var prayer = new PrayerModel();
            //prayer3.Id = 1;
            //prayer3.Lyrics = "Some of the companions of the Prophet (ﷺ) came across a tribe amongst the tribes of the Arabs, and that tribe did not entertain them.\n While they were in that state, the chief of that tribe was bitten by a snake (or stung by a scorpion).\n They said, (to the companions of the Prophet (ﷺ) ), 'Have you got any medicine with you or anybody who can treat with Ruqya?'\n The Prophet's companions said, 'You refuse to entertain us, so we will not treat(your chief) unless you pay us for it.' So they agreed to pay them a flock of sheep. One of them (the Prophet's companions)\n started reciting Surat-al-Fatiha and gathering his saliva and spitting it (at the snake-bite).\n The patient got cured and his people presented the sheep to them, but they said, 'We will not take it unless we ask the Prophet(whether it is lawful).' \n When they asked him, he smiled and said, 'How do you know that Surat - al - Fatiha is a Ruqya ? Take it(flock of sheep) and assign a share for me.";
            //prayer3.Reason = PrayerReasonType.GENERAL;
            //prayer3.Religion = ReligionType.MUSLIM;
            //context.Prayers.Add(prayer1);
        }
    }
}
