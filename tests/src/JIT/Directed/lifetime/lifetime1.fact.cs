using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _lifetime_lifetime1_lifetime1_
    {
        [OuterLoop]
        [Fact]
        public void _lifetime_lifetime1_lifetime1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\lifetime\\lifetime1\\lifetime1.cmd");
        }
    }
}
