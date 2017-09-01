using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Boxing_seh__relfault__relfault_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_seh__relfault__relfault_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\seh\\_relfault\\_relfault.cmd");
        }
    }
}
