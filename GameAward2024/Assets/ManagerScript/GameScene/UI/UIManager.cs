using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScene
{
	public class UIManager : ManagerBase
	{
		[SerializeField]
		PlayerHpGaugeController m_playerGaugeController;
		/// <summary>
		/// PlayerGaugeControllerを取得
		/// </summary>
		public PlayerHpGaugeController playerGaugeController => m_playerGaugeController;

		[SerializeField]
		EnemyHpGaugeController m_enemyGaugeController;
		/// <summary>
		/// EnemyHpGaugeControllerを取得
		/// </summary>
		public EnemyHpGaugeController enemyGaugeController => m_enemyGaugeController;

		[SerializeField]
		TimeGaugeController m_timeGaugeController;
		/// <summary>
		/// TimeGaugeControllerを取得
		/// </summary>
		public TimeGaugeController timeGaugeController => m_timeGaugeController;
	}
}