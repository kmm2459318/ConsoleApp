#pragma once
//======================================
//	�R�}���hUI
//======================================
// �������ɃC���N���[�h�K�[�h(�J�n)���L�����Ă��������B

#include "Command.h"
#include "TurnBattle.h"
#ifndef __COMMANDUI_H
#define __COMMANDUI_H


// �v���[���̃R�}���h�擾
Command GetPlayerCommand(TurnBattle* btl);
// �G�̃R�}���h�擾
Command GetEnemyCommand();

// �������ɃC���N���[�h�K�[�h(�I��)���L�����Ă��������B
#endif