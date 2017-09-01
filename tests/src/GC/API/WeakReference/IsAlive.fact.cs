using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _WeakReference_IsAlive_IsAlive_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_IsAlive_IsAlive_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\WeakReference\\IsAlive\\IsAlive.cmd");
        }
    }
}
