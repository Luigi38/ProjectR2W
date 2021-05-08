using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LCUSharp;
using LCUSharp.Websocket;

using ProjectR2W.Properties;
using ProjectR2W.Others;
using System.Collections.ObjectModel;

namespace ProjectR2W.Clients
{
    /// <summary>
    /// 리그 오브 레전드 (LCU) API 클라이언트
    /// </summary>
    public class LolClient
    {
        // 일부 코드는 ProjectReinforced/Clients/LolClient.cs 에서 가져왔습니다.

        /// <summary>
        /// 롤 프로세스 이름
        /// </summary>
        public const string PROCESS_NAME = "League of Legends";

        /// <summary>
        /// 롤 프로세스 제목
        /// </summary>
        public const string PROCESS_TITLE = "League of Legends (TM) Client";

        /// <summary>
        /// LCU 클라이언트
        /// </summary>
        public static LeagueClientApi Client { get; private set; }

        /// <summary>
        /// 롤이 현재 실행 중인가? (클라이언트만)
        /// </summary>
        public static bool IsRunningClient => ProcessManager.IsRunning(PROCESS_NAME);

        /// <summary>
        /// 롤이 현재 실행 중인가? (인 게임)
        /// </summary>
        public static bool IsRunningGame => ProcessManager.IsRunning(PROCESS_TITLE);

        /// <summary>
        /// 롤이 현재 실행 중인가? (클라이언트나 인 게임)
        /// </summary>
        public static bool IsRunning => IsRunningClient || IsRunningGame;

        /// <summary>
        /// 챔피언을 선택할 때
        /// </summary>
        public static event EventHandler<LeagueEvent> OnChampSelect;

        public static ReadOnlyCollection<string> En;
        public static ReadOnlyCollection<string> Kr;

        public static Dictionary<string, string> KrToEn = new Dictionary<string, string>();
        public static Dictionary<string, string> EnToKr = new Dictionary<string, string>();

        public static async Task Initialize()
        {
            //Clients
            //Client = await LeagueClientApi.ConnectAsync();

            //Events
            OnChampSelect += LolClient_OnChampSelect;

            //LoL Contents
            var newLines = new[] { '\r', '\n' };

            var names = Resources.LolChampions.Split(newLines, StringSplitOptions.RemoveEmptyEntries).ToList();
            var names_kr = Resources.LolChampions_kr.Split(newLines, StringSplitOptions.RemoveEmptyEntries).ToList();

            En = names.OrderBy((x) => x).ToList().AsReadOnly();
            Kr = names_kr.OrderBy((x) => x).ToList().AsReadOnly();

            for (int i = 0; i < names.Count; i++)
            {
                var name = names[i];
                var name_kr = names_kr[i];

                KrToEn.Add(name_kr, name);
                EnToKr.Add(name, name_kr);
            }
        }

        private static void LolClient_OnChampSelect(object sender, LeagueEvent e)
        {

        }
    }
}
