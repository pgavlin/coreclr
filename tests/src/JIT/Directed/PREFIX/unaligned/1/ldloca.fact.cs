using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_unaligned_1_ldloca_ldloca_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_unaligned_1_ldloca_ldloca_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\unaligned\\1\\ldloca\\ldloca.cmd");
        }
    }
}
