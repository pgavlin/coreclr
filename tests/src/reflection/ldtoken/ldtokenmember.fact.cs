using CoreclrTestLib;
using Xunit;

namespace reflection_ldtoken
{
    class _ldtokenmember_ldtokenmember_
    {
        [OuterLoop]
        [Fact]
        public void _ldtokenmember_ldtokenmember_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("reflection\\ldtoken\\ldtokenmember\\ldtokenmember.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
