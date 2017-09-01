using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _regressions_devdiv489437_test489437_test489437_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_devdiv489437_test489437_test489437_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\regressions\\devdiv489437\\test489437\\test489437.cmd");
        }
    }
}
