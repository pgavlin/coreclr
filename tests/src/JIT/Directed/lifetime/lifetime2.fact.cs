using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _lifetime_lifetime2_lifetime2_
    {
        [OuterLoop]
        [Fact]
        public void _lifetime_lifetime2_lifetime2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\lifetime\\lifetime2\\lifetime2.cmd");
        }
    }
}
