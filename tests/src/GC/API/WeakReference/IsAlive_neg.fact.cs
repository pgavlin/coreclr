using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _WeakReference_IsAlive_neg_IsAlive_neg_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_IsAlive_neg_IsAlive_neg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\WeakReference\\IsAlive_neg\\IsAlive_neg.cmd");
        }
    }
}
