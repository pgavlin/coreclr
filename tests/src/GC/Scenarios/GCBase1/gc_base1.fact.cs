using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _GCBase1_gc_base1_gc_base1_
    {
        [OuterLoop]
        [Fact]
        public void _GCBase1_gc_base1_gc_base1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\GCBase1\\gc_base1\\gc_base1.cmd");
        }
    }
}
