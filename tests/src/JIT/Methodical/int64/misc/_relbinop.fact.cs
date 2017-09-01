using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _int64_misc__relbinop__relbinop_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__relbinop__relbinop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_relbinop\\_relbinop.cmd");
        }
    }
}
