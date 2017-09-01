using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _int64_misc__speed_relbinop__speed_relbinop_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__speed_relbinop__speed_relbinop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_speed_relbinop\\_speed_relbinop.cmd");
        }
    }
}
