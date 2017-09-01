using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _GCBase1_gc_base1_1_gc_base1_1_
    {
        [OuterLoop]
        [Fact]
        public void _GCBase1_gc_base1_1_gc_base1_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\GCBase1\\gc_base1_1\\gc_base1_1.cmd");
        }
    }
}
