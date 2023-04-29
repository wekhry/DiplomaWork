import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { ToDoEditComponent } from '../to-dos/to-do-edit/to-do-edit.component';

@Injectable({
  providedIn: 'root'
})
export class PreventUnsavedChangesGuard implements CanDeactivate<ToDoEditComponent> {
  canDeactivate(component: ToDoEditComponent): boolean {
    if (component.editForm?.dirty) {
      return confirm('Are you sure you want to continue? Any unsaved changes will be lost.');
    }
    return true;
  }
  
}
