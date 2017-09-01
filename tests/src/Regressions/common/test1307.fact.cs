using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _test1307_test1307_
    {
        [OuterLoop]
        [Fact]
        public void _test1307_test1307_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\test1307\\test1307.cmd");
        }
    }
}
