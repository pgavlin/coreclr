using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_4_ldind_stind_ldind_stind_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_4_ldind_stind_ldind_stind_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\4\\ldind_stind\\ldind_stind.cmd");
        }
    }
}
