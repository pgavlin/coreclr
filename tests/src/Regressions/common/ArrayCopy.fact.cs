using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _ArrayCopy_ArrayCopy_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayCopy_ArrayCopy_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\ArrayCopy\\ArrayCopy.cmd");
        }
    }
}
