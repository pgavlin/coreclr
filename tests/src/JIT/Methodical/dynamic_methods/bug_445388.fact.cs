using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _dynamic_methods_bug_445388_bug_445388_
    {
        [OuterLoop]
        [Fact]
        public void _dynamic_methods_bug_445388_bug_445388_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\dynamic_methods\\bug_445388\\bug_445388.cmd");
        }
    }
}
