//====================================
//	3Dダンジョン  キャラクタ
//======================================
#include "Character.h"
#include "Direction.h"
#include "Vector2.h"

// 初期化
void InitCharacter(Character* ch, Vector2 pos, Direction dir)
{
	ch->pos = pos = { 0,7 };
	ch->dir = dir;
}
//　後ろを向く
void TurnBackCharacter(Character* ch)
{
	// 北←→南、西←→東
	// ★ここをコーディングしてください
	// DirectionAdd()を呼びます
	ch->dir = DirectionAdd(ch->dir, 2);
}
// 左を向く
void TurnLeftCharacter(Character* ch)
{
	// 北→西→南→東
	// ★ここをコーディングしてください
	// DirectionAdd()を呼びます
	ch->dir = DirectionAdd(ch->dir, 1);
}
// 右を向く
void TurnRightCharacter(Character* ch)
{
	// 北→東→南→西
	// ★ここをコーディングしてください
	// DirectionAdd()を呼びます
	ch->dir = DirectionAdd(ch->dir, -1);
}