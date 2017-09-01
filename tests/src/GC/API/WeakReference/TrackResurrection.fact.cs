using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _WeakReference_TrackResurrection_TrackResurrection_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_TrackResurrection_TrackResurrection_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\WeakReference\\TrackResurrection\\TrackResurrection.cmd");
        }
    }
}
