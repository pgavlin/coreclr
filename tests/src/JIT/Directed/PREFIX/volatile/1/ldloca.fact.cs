using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _PREFIX_volatile_1_ldloca_ldloca_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_volatile_1_ldloca_ldloca_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\volatile\\1\\ldloca\\ldloca.cmd");
        }
    }
}
