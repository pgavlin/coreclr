using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _LeakGen_leakgenthrd_leakgenthrd_
    {
        [OuterLoop]
        [Fact]
        public void _LeakGen_leakgenthrd_leakgenthrd_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\LeakGen\\leakgenthrd\\leakgenthrd.cmd");
        }
    }
}
