using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0046_istype_istype_
    {
        [OuterLoop]
        [Fact]
        public void _0046_istype_istype_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0046\\istype\\istype.cmd");
        }
    }
}
