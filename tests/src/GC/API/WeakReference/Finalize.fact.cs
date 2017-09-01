using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _WeakReference_Finalize_Finalize_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_Finalize_Finalize_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\WeakReference\\Finalize\\Finalize.cmd");
        }
    }
}
