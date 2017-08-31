using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchmarksGame_fannkuch_redux_fannkuch_redux_fannkuch_redux_
    {
        [Fact]
        public void _CodeQuality_BenchmarksGame_fannkuch_redux_fannkuch_redux_fannkuch_redux_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchmarksGame\\fannkuch-redux\\fannkuch-redux\\fannkuch-redux.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
