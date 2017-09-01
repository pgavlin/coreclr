using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_loop2_cs_d_loop2_cs_d_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop2_cs_d_loop2_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop2_cs_d\\loop2_cs_d.cmd");
        }
    }
}
