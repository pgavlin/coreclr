using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_dev10_813331_Case1_Case1_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_813331_Case1_Case1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_813331\\Case1\\Case1.cmd");
        }
    }
}
