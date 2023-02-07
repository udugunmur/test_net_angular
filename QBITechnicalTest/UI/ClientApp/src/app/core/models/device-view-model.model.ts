import { DeviceTypeViewModel } from './device-type-view-model.model';
import { ProjectViewModel } from './project-view-model.model';

export interface DeviceViewModel {
    deviceLogicalId: number;
    deviceTypeId: number;
    parentId: number;
    projectId: number;
    deviceLogicalName: string;
    assetCode: string;
    disabled: boolean;
    updateDate: Date;
    updateUserId: number;
    updateUserName: string;
    deviceType: DeviceTypeViewModel;
    parent: DeviceViewModel;
    project: ProjectViewModel;
}