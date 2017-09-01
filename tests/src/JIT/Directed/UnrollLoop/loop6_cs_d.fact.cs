using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_loop6_cs_d_loop6_cs_d_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop6_cs_d_loop6_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop6_cs_d\\loop6_cs_d.cmd");
        }
    }
}
