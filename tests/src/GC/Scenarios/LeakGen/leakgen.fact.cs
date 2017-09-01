using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _LeakGen_leakgen_leakgen_
    {
        [OuterLoop]
        [Fact]
        public void _LeakGen_leakgen_leakgen_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\LeakGen\\leakgen\\leakgen.cmd");
        }
    }
}
