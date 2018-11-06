// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "NiagaraDataInterfaceStaticMesh.h"
#include "MyNiagaraDataInterface.generated.h"

/**
 * 
 */
UCLASS(EditInlineNew, Category = "Meshes", meta = (DisplayName = "My Mesh"))
class FORSHAUN_API UMyNiagaraDataInterface : public UNiagaraDataInterfaceStaticMesh
{
	GENERATED_BODY()

	virtual bool InitPerInstanceData(void* PerInstanceData, FNiagaraSystemInstance* SystemInstance) override;
};
