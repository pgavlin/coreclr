using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _WeakReference_Target_Target_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_Target_Target_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\WeakReference\\Target\\Target.cmd");
        }
    }
}
