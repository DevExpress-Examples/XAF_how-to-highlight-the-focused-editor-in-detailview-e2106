using DevExpress.XtraLayout;

namespace WinWebSolution.Module.Win {
    public class WinHighlightFocusedLayoutItemDetailViewController : HighlightFocusedLayoutItemDetailViewControllerBase {
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            ApplyFocusedStyle(View.LayoutManager.Container);
        }
        protected override void ApplyFocusedStyle(object control) {
            LayoutControl layoutControl = control as LayoutControl;
            if (layoutControl != null) {
                layoutControl.BeginUpdate();
                layoutControl.OptionsView.HighlightFocusedItem = true;
                layoutControl.OptionsView.AllowItemSkinning = true;
                layoutControl.EndUpdate();
            }
        }
    }
}