import { ToastOptions } from 'ng2-toastr';

export class ToastConfig extends ToastOptions {
  animate = 'flyRight'; // you can override any options available
  positionClass = 'toast-top-center';
  showCloseButton: true;
};
