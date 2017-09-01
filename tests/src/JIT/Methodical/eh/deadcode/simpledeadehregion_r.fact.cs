using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_simpledeadehregion_r_simpledeadehregion_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_simpledeadehregion_r_simpledeadehregion_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\simpledeadehregion_r\\simpledeadehregion_r.cmd");
        }
    }
}
