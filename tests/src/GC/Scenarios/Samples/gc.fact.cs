using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _Samples_gc_gc_
    {
        [OuterLoop]
        [Fact]
        public void _Samples_gc_gc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\Samples\\gc\\gc.cmd");
        }
    }
}
