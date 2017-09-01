using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _date_date_
    {
        [Fact]
        public void _date_date_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\date\\date.cmd");
        }
    }
}
