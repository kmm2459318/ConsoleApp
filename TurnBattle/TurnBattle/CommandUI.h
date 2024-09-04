#pragma once
//======================================
//	コマンドUI
//======================================
// ★ここにインクルードガード(開始)を記入してください。

#include "Command.h"
#include "TurnBattle.h"
#ifndef __COMMANDUI_H
#define __COMMANDUI_H


// プレーヤのコマンド取得
Command GetPlayerCommand(TurnBattle* btl);
// 敵のコマンド取得
Command GetEnemyCommand();

// ★ここにインクルードガード(終了)を記入してください。
#endif