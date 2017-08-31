using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _WeakReference_TrackResurrection_TrackResurrection_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_TrackResurrection_TrackResurrection_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\WeakReference\\TrackResurrection\\TrackResurrection.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
