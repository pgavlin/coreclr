using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _WeakReference_weakreffinal_weakreffinal_
    {
        [OuterLoop]
        [Fact]
        public void _WeakReference_weakreffinal_weakreffinal_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\WeakReference\\weakreffinal\\weakreffinal.cmd");
        }
    }
}
