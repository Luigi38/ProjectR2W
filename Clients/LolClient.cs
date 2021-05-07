using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LCUSharp;
using LCUSharp.Websocket;

using ProjectR2W.Others;

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

        public static List<string> En = new List<string>();
        public static List<string> Kr = new List<string>();

        public static Dictionary<string, string> KrToEn = new Dictionary<string, string>();
        public static Dictionary<string, string> EnToKr = new Dictionary<string, string>();

        public static async Task Initialize()
        {
            Client = await LeagueClientApi.ConnectAsync();

            OnChampSelect += LolClient_OnChampSelect;
        }

        private static void LolClient_OnChampSelect(object sender, LeagueEvent e)
        {

        }
    }
}
