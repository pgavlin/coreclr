using CoreclrTestLib;
using Xunit;

namespace reflection_ldtoken
{
    public class _byrefs_byrefs_
    {
        [OuterLoop]
        [Fact]
        public void _byrefs_byrefs_cmd()
        {
            CoreclrTestWrapperLib.RunTest("reflection\\ldtoken\\byrefs\\byrefs.cmd");
        }
    }
}
